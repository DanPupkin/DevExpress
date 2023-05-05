namespace DevExpress
    {
    public class Program
    {
        public static void Main(string[] args)
        {
            
            object[] objects = new object[3];
            
            objects[0]= new Person { Name = "Abibus", Age =228 };
            objects[1] = new Person { Name = "Abobus", Age = 30 };
            objects[2] = new Dog { Name = "Bobik", Poroda = "Psina" };
            
            Controller controller = new Controller();
            Console.Write(controller.GetReport(objects));
        }
    }

    }
