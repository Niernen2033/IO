using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using OptimizationGlobals;

namespace OptimizationTests
{
    class Tests
    {
        private List<string> testLogs;
        private Dictionary<string, bool> allTests;
        private List<string> testData;

        public ReadOnlyDictionary<string, bool> AllTests { get { return new ReadOnlyDictionary<string, bool>(this.allTests); } }

        public Tests()
        {
            this.allTests = new Dictionary<string, bool>();
            this.testData = new List<string>();
            this.testLogs = new List<string>();

            //if true - additional data neede
            this.allTests.Add("HAMJ - HeuristicAlgorithmsTest", true); // <== 0
        }

        public async void Begin(int testIndex, ListBox logsBox, object optionalData = null)
        {
            this.testLogs.Clear();
            switch(testIndex)
            {
                case 0:
                    {
                        await BeginHeuristicAlgorithmsTest((HATestUnit)optionalData, logsBox);
                        break;
                    }
                case 1:
                    {
                        BeginLagrangeInterpolationTest((LagrangeInterpolationTestUnit)optionalData, logsBox);
                        break;
                    }
            }
        }

        private void BeginLagrangeInterpolationTest(LagrangeInterpolationTestUnit liTestUnit, ListBox logsBox)
        {
            Communication.LagrangeInterpolation lagrangeInterpolation = new Communication.LagrangeInterpolation();

            for(int i=0; i<liTestUnit.FileToTest.Count; i++)
            {
                //petla przez wszystkie pliki
                if(!lagrangeInterpolation.LoadFile(liTestUnit.FileToTest[i].Path, liTestUnit.FileToTest[i].FileType))
                {
                    //cos poszlo nie tak z wczytaniem pliku
                }
                else
                {
                    //wszystko ok
                }
                string function_expression;
                string function_variables;

                if(!lagrangeInterpolation.GenerateFunctionExpression(out function_expression, out function_variables))
                {
                    //cos poszlo nie tak z wygenerowaniem funkcji
                }
                else
                {
                    //wszystko ok
                }
            }
        }

        private async Task BeginHeuristicAlgorithmsTest(HATestUnit hATestUnit, ListBox logsBox)
        {
            OptimizationAlpha.HeuristicAlgorithms heuristicAlgorithms = new OptimizationAlpha.HeuristicAlgorithms();
            logsBox.Items.Add("Test begin");
            this.testLogs.Add(logsBox.Items[logsBox.Items.Count - 1].ToString());

            int globalPassCount = 0;
            for (int i = 0; i < hATestUnit.HATestDatas.Count; i++)
            {
                logsBox.Items.Add("Function " + (i+1).ToString() + " test in progrss:");
                this.testLogs.Add(logsBox.Items[logsBox.Items.Count - 1].ToString());
                logsBox.Items.Add("\tType: " + hATestUnit.HATestDatas[i].Type);
                this.testLogs.Add(logsBox.Items[logsBox.Items.Count - 1].ToString());
                logsBox.Items.Add("\tFunctionExpression: " + hATestUnit.HATestDatas[i].FunctionExpression);
                this.testLogs.Add(logsBox.Items[logsBox.Items.Count - 1].ToString());
                string argumentsSymbols = string.Empty;
                for (int j = 0; j < hATestUnit.HATestDatas[i].ArgumentsSymbols.Count; j++)
                {
                    argumentsSymbols += "{ " + hATestUnit.HATestDatas[i].ArgumentsSymbols[j] + " } , ";
                }
                logsBox.Items.Add("\tArgumentsSymbols: " + argumentsSymbols);
                this.testLogs.Add(logsBox.Items[logsBox.Items.Count - 1].ToString());
                string ranges = string.Empty;
                for (int j = 0; j < hATestUnit.HATestDatas[i].ArgumentsSymbols.Count; j++)
                {
                    ranges += "{ " + hATestUnit.HATestDatas[i].Ranges[j].Min + " ; " + hATestUnit.HATestDatas[i].Ranges[j].Max + " } , ";
                }
                logsBox.Items.Add("\tRanges: " + ranges);
                this.testLogs.Add(logsBox.Items[logsBox.Items.Count - 1].ToString());
                logsBox.Items.Add("Process started");
                this.testLogs.Add(logsBox.Items[logsBox.Items.Count - 1].ToString());
                logsBox.Items.Add("Progress: 0 %");

                int passCount = 0;
                for (int j = 0; j < 10; j++)
                {
                    List<FitnessPoint> results = null;
                    try
                    {
                        results = await heuristicAlgorithms.GetAllOptimalPointsAsync(hATestUnit.HATestDatas[i].Type, hATestUnit.HATestDatas[i].FunctionExpression, hATestUnit.HATestDatas[i].ArgumentsSymbols, hATestUnit.HATestDatas[i].Ranges);
                    }
                    catch
                    {
                        continue;
                    }
                    for (int k = 0; k < results.Count; k++)
                    {
                        string position = string.Empty;
                        for (int l = 0; l < results[k].Axis.Values.Count; l++)
                        {
                            position += Math.Round(results[k].Axis.Values[l], 2, MidpointRounding.AwayFromZero) + " , ";
                        }

                        //logsBox.Items.Add("Position: [ " + position + " ]  || Fitness: " + Math.Round(results[k].Fitness, 2, MidpointRounding.AwayFromZero));
                        this.testLogs.Add("Position: [ " + position + " ]  || Fitness: " + Math.Round(results[k].Fitness, 2, MidpointRounding.AwayFromZero));
                    }
                    if((results[j].Fitness < hATestUnit.HATestDatas[i].ExpectedValue + 0.02) 
                        && (results[j].Fitness > hATestUnit.HATestDatas[i].ExpectedValue - 0.02))
                    {
                        passCount++;
                    }

                    logsBox.Items[logsBox.Items.Count - 1] = "Progress: " + ((j + 1) * 10).ToString() + " %";
                }

                if(passCount >= 8)
                {
                    globalPassCount++;
                    //logsBox.Items.Add("Function passed");
                    this.testLogs.Add("Function passed");
                }
                else
                {
                    //logsBox.Items.Add("Function fail");
                    this.testLogs.Add("Function fail");
                }
                //logsBox.Items.Add("======================================================");
                this.testLogs.Add("=========================================================================");
            }

            logsBox.Items.Add("===========================================================");
            this.testLogs.Add(logsBox.Items[logsBox.Items.Count - 1].ToString());
            logsBox.Items.Add("========================RESULT============================");
            this.testLogs.Add(logsBox.Items[logsBox.Items.Count - 1].ToString());
            logsBox.Items.Add("===========================================================");
            this.testLogs.Add(logsBox.Items[logsBox.Items.Count - 1].ToString());
            logsBox.Items.Add("FUNCTIONS PASS: " + globalPassCount);
            this.testLogs.Add(logsBox.Items[logsBox.Items.Count - 1].ToString());
            logsBox.Items.Add("FUNCTIONS FAIL: " + (hATestUnit.HATestDatas.Count-globalPassCount));
            this.testLogs.Add(logsBox.Items[logsBox.Items.Count - 1].ToString());

            logsBox.Items.Add("Saving logs to: " + Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HeuristicAlgorithmsTest_logs.txt");

            using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\HeuristicAlgorithmsTest_logs.txt"))
            {
                for(int i=0; i<this.testLogs.Count; i++)
                {
                    writer.WriteLine(this.testLogs[i]);
                }
            }
        }
    }
}
