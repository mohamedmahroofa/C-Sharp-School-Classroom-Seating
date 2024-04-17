using System;


namespace Assignment3;

public class Program
{
    public static void Main(string[] args)
    {
        School macewan = new School
        {
            Name = "MacEwan",
            ClassRooms = new List<ClassRoom>
            {
                new ClassRoom
                {
                    Id = "R530",
                    Desks = new List<Desk>
                    {
                        new Desk{Id = "Desk1"},
                        new Desk{Id = "Desk2"},
                        new Desk{Id = "Desk3"}
                    }
                },

                new ClassRoom
                {
                    Id = "R531",
                    Desks = new List<Desk>
                    {
                        new Desk{Id = "Desk1"},
                        new Desk{Id = "Desk2"},
                        new Desk{Id = "Desk3"}
                    } 
                },

                new ClassRoom
                {
                    Id = "R532",
                    Desks = new List<Desk>
                    {
                        new Desk{Id = "Desk1"},
                        new Desk{Id = "Desk2"},
                        new Desk{Id = "Desk3"}
                    }   
                }
            }
        };

       
        System.Console.WriteLine($"School:{macewan.Name}");
       
        foreach(var classRoom in macewan.ClassRooms)
        {
            if(classRoom == null)
            {
                continue;
            }
            System.Console.WriteLine($"ClassRoom:{classRoom.Id}");
            foreach(var desk in classRoom.Desks)
            {
                System.Console.Write($"{desk.Id}  ");
            }
            System.Console.WriteLine();
        }

    }
}
