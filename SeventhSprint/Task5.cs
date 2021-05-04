using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace FirstSpring
{

    public class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Worker Manager { get; set; }
        public Department(string name, int id, Worker manager)
        {
            Name = name;
            Id = id;
            Manager = manager;
        }
        public Department() { }
    }
    public class Worker
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonPropertyName("Full name")]
        public string Name { get; set; }
        public decimal Salary { get; set; }
        
        public Department Department { get; set; }
        public Worker(string name, decimal salary, Department department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
        public Worker() { }

        public string Serialize()
        {
            var options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                WriteIndented = true
            };
            
            return JsonSerializer.Serialize<Worker>(this, options);
        }
        public static Worker Deserialize(string json)
        {
            return JsonSerializer.Deserialize<Worker>(json);
        }
    }
}
