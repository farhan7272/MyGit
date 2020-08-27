using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Models
{
    public class DataProcess
    {
        private IndexViewModel _model;
        public DataProcess(IndexViewModel model)
        {
            _model = model;
        }

        public IndexViewModel ExecuteDataProcess()
        {
            List<string> values = new List<string>();
            values.Add(_model.Value1);
            values.Add(_model.Value2);
            values.Add(_model.Value3);
            values.Add(_model.Value4);
            values.Add(_model.Value5);
            values.Add(_model.Value6);
            values.Add(_model.Value7);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"You have entered following values\n");

            foreach (var item in values)
            {
                stringBuilder.Append($"{item}\n");
            }

            stringBuilder.Append("------------------OutPut-----------\n");
            foreach (var item in values)
            {
                try
                {
                    if(string.IsNullOrWhiteSpace(item))
                    {
                        throw new InvalidCastException();
                    }
                    int iValue = Convert.ToInt32(item);
                    bool divisibleby3 = false;                    
                    
                    stringBuilder.Append($"Divided {iValue} by 3\n");
                    
                    if (iValue % 3 == 0)
                    {
                        divisibleby3 = true;
                        stringBuilder.Append($"Fizz\n");
                    }

                    stringBuilder.Append($"Divided {iValue} by 5\n");
                   
                    if (iValue % 5 == 0)
                    {
                        if (divisibleby3)
                        {
                            stringBuilder.Append($"FizzBuzz\n");
                        }
                        else
                        {
                            stringBuilder.Append($"Buzz\n");
                        }
                    }
                    
                }
                catch(Exception ex)
                {
                    stringBuilder.Append($"Invalid Item\n");
                }

            }

            _model.ProcessedData = stringBuilder.ToString();
            return _model;
        }
    }
}
