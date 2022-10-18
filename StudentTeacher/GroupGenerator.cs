using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{
    class GroupGenerator : Member
    {
        public List<Member> Groups(int count)
        {
            var group = new List<Member>();
            for (int i = 1; i <= count; i++)
            {
               
                group.Add(new Member { name = (Names.Name)i, lastName = (Names.LastName)i, id = i, ocupation = "Student" });
     
            }
            
            return group;
        }
       
        public void ShowInfo(GroupGenerator grp,int i)
        {
            var group=grp.Groups(i);
            foreach (var item in group)
            {
                Console.WriteLine($"{name}, {lastName}, {ocupation}, {id}");
            }
        }    
        
    }
}
