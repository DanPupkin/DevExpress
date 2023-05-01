namespace DevExpress
    {
    public class Program
    {
        public static void Main(string[] args)
        {
            Controller controller = new Controller();
            object[] objects = new object[2];
            
            objects[0]= new Person { Name = "Abibus", Age = 228 };
            objects[1] = new Person { Name = "Abobus", Age = 30 };

            Console.Write(controller.GetReport(objects, false));
        }
    }

    }
