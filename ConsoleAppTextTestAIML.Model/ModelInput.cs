// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace ConsoleAppTextTestAIML.Model
{
    public class ModelInput
    {
        [ColumnName("Id"), LoadColumn(0)]
        public float Id { get; set; }


        [ColumnName("Email"), LoadColumn(1)]
        public string Email { get; set; }


        [ColumnName("CategoryId"), LoadColumn(2)]
        public string CategoryId { get; set; }


    }
}