namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            //1.Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this enum.

            //public enum WeekDays
            //{
            //   Monday , 
            //   Tuesday ,
            //   Wenesday,
            //   Thursday ,
            //   Friday ,
            //   Saturday ,
            //   Sunday
            //}
            #endregion


            #region Question 02
            //3.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //public enum Season
            //{
            //    Spring, 
            //    Summer,
            //    Autumn,
            //    Winter
            //}
            #endregion



            #region Question 04
            //4.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            //[Flags]
            //public enum Permissions
            //{
            //    Read = 1,
            //    Write = 2, 
            //    Delete = 4,
            //    Execute = 8,
            //}
            #endregion

            #region Question 05
            //5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //public enum Colors
            //{
            //    Red, 
            //    Green,
            //    Blue
            //}

            #endregion





                                        //Demo 
            // dataType => Reference Type (Class,  Interface) ,ValueType (Struct , Enum)

    //        #region Enum

    //enum Color : byte
    //    {
    //        Red = 10,
    //        Green,
    //        Blue
    //    }

    //    enum Gender
    //    {
    //        Male = 1,
    //        Female = 2,
    //        M = 1,
    //        F = 2
    //    }

    //    [Flags]
    //    enum FilePermissions
    //    {
    //        Read = 1,
    //        Write = 2,
    //        Execute = 4,
    //        Delete = 8
    //    }
        //#endregion

        //class Permissionss 
        //{
        //    public bool HasRead;
        //    public bool HasWrite;
        //    public bool HasExecute;
        //    public bool HasDelete;

        //}



        //internal class Program
        //{
        //    #region Error Handling

        //    public static void SomeBadCode(int[] arr)
        //    {
        //        int x, y, z;

        //        x = int.Parse(Console.ReadLine());
        //        y = int.Parse(Console.ReadLine());
        //        z = x / y;

        //        arr[z] = x;
        //    }


        //    public static void SomeProtectedCode(int[] arr)
        //    {
        //        int x, y, z;
        //        do
        //        {
        //            Console.WriteLine("Please Enter An Number :");

        //        }
        //        while (!int.TryParse(Console.ReadLine(), out x));

        //        do
        //        {
        //            Console.WriteLine("Please Enter second  Number [Can't be zero]:");

        //        }
        //        while (!int.TryParse(Console.ReadLine(), out y) || y == 0);

        //        z = x / y;

        //        if (z < arr?.Length)
        //        {
        //            arr[z] = x;
        //        }




        //    }

        //    public static void someCode()
        //    {
        //        throw new NotImplementedException();
        //    }
        //    public static void someCode2()
        //    {
        //        throw new OutOfMemoryException();
        //    }
        //    public static void someCode3()
        //    {
        //        throw new ArgumentNullException();
        //    }
        //    public static void someCode4()
        //    {
        //        throw new DivideByZeroException();
        //    }

        //    public static void GetUserName()
        //    {
        //        string name;

        //        do
        //        {
        //            Console.WriteLine("Enter Your Name");
        //            name = Console.ReadLine();
        //        } while (string.IsNullOrWhiteSpace(name));

        //        Console.WriteLine(name);
        //    }
        //    #endregion

        //    static void Main(string[] args)
        //    {

        //        #region Error Handling


                //Unmanaged Resources => DbConnection , File, etc
                //try
                //{
                //    Console.WriteLine("Start Project");

                //    //SomeBadCode([1,2,3]);
                //    //SomeProtectedCode([1, 2, 3]);

                //    //open dbConnection

                //    // someCode();

                //    GetUserName();


                //    //close DbConnection


                //}
                //catch (DivideByZeroException)
                //{
                //    Console.WriteLine("Hello Don't divide by zero ");
                //    //close DbConnection


                //}
                //catch (ArgumentNullException)
                //{
                //    Console.WriteLine("hi this object is null ");
                //    //close DbConnection

                //}
                //catch (Exception ex)
                //{

                //    Console.WriteLine(ex.Message);
                //    //close DbConnection

                //}
                //finally
                //{
                //    Console.WriteLine("Db Is Closed Succesfuly");

                //    //release or free or Dispose UnManaged REsources [Db Connection, FIle , etc]
                //}

                //Console.WriteLine("End of Project");



                //#endregion

                //#region Enum

                //Color color = Color.Green;

                //int x = (int)color; //Explicit Casting

                //Color color = (Color)16; //Explicit Casting

                //Console.WriteLine(color);


                //Gender gender = Gender.M;
                //int x = (int)gender;
                //gender = (Gender)x;
                //Console.WriteLine(gender);

                //Gender gender1 = (Gender)"Male";

                //Enum.TryParse(typeof(Gender),"m",true, out object result );

                //bool flag = Enum.TryParse<Gender>("m",true, out Gender result1 );


                //Console.WriteLine(result1);

                //FilePermissions permissions= FilePermissions.Read;

                //permissions |= FilePermissions.Write;

                //if((permissions & FilePermissions.Read ) == FilePermissions.Read)
                //{
                //    permissions ^= FilePermissions.Read;
                //}

                //permissions ^= FilePermissions.Execute;

                //int x = (int)permissions;

                //Console.WriteLine(x); 
                //#endregion


                //#region Access Modifiers
                //Point point = new Point();       
                //point.x = 10;

                //TypeA typeA = new TypeA();
                ////stypeA.x = 10;
                //typeA.y = 10;
                //typeA.H = 10;

                //typeA.B;


                //TypeB typeB = new TypeB();

                //typeB.y = 10;

                //typeB.z = 10;
                //typeB.B; typeB.H = 10;


                //TypeC typeC = new TypeC();

                //typeC.z = 10;

                //typeC.B;
                //typeC.H = 10;


                //TypeD typeD = new TypeD();

                //typeD.B;

                //typeD.H = 10; 
                //#endregion



            }
        }
}
