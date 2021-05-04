using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace FirstSpring
{
    class Student
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        public string GroupName { get; set; }

    }
    class Group
    {
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        public int Popularity { get; set; }
        public static string CreateGroups(List<Student> students, List<Group> groups)
        {            
            var options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                WriteIndented = true
            };
            var result = groups.GroupJoin(students, g => g.Name, s => s.GroupName, (group, student) => new
            {
                group = group.Name,
                description = group.Description,
                rating = student.Select(x => x.Rating).Sum() / student.Count(),
                students = student.Select(i => new { FullName = i.Name, AvgMark = i.Rating })
            }); 
            return JsonSerializer.Serialize(result, options);
        }
    }
}
