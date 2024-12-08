namespace HR
{
    public class Person : IDisposable
    {
        public Person()
        {
            this.FirstName = "";
            this.LastName = "";
            this.BirthDate = DateTime.Now;

            //initializing system resources at the time creation of object 
            
            // alocate system resoures which would be needed 
            // further fir execution
            // database connections,
            // multiple threads,
            // files


        }
        public Person(string fname, string lname, DateTime bdate)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.BirthDate = bdate;
        }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + BirthDate;
        }

        public void show()
        {

        }

        public void Dispose()
        {
            // Deinitializing system resources before object get destroyed

            // Releasing system resources which were used
            // database connections,
            // multiple threads,
            // files

            GC.SuppressFinalize(this);
        }

        ~Person()
        {
            // Deinitializing system resources before object get destroyed

            // Releasing system resources which were used
            // 
            // database connections,
            // multiple threads,
            // files
        }
    }
}
