//Do not call us we will call you

//HR departmrnt will have jobportal
namespace RecruitmentApp
{

    //Bussiness Entity    
    public class Resume{
        public string Name{get;set;}
        public string Email{get;set;}
        public string Content{get;set;}

        public override string ToString()
        {
            return "Resume [email= " + Email + ", name = " + Name + ", content = " + Content + "]";
        }
    }

    // Singleton class
    //Business Process Management
    public class JobPortal{
        
        //static variable
        //hollywood princicple 
        //SOLID principle

        //Application architecture
        //singleton design pattern
        //only instanace of a class will be created

        //Rules
        //1.define portal as static variable for class and initialize
        //2.Private constructor
        //3. always invoke instance through static method
        private static JobPortal portal = new JobPortal();
        private List<Resume> resumeList=new List<Resume>();

        public JobPortal(){
            Console.WriteLine("new job portal instance created..");
        }
        //3. always invoke instance through static method
        public static JobPortal Get(){
            //reference of instance
            return portal;
        }

        public void uploadContent(string mail, string name, string content)
        {
            Resume resume = new Resume();
            resume.Name = name;
            resume.Email = mail;
            resume.Content = content;
            resumeList.Add(resume);
        }

        public void triggerCampusing()
        {
            foreach(Resume resume in resumeList)
            {
                Console.WriteLine("Sending mail to " + resume.Name + " at " + resume.Email);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Testing
            //Dont call us , we will call you
            //Access Jobportal 
            //Upload resumes
            
            //notify indirectly to all candidates

            JobPortal portal = JobPortal.Get();
            
            portal.uploadContent("pranav.taware@gmail.com", "Pranav Taware", "A dotnet developer");
            portal.uploadContent("amit.kumar@gmail.com", "Amit Kumar", "A Java Developer");
            portal.uploadContent("sneha.rai@gmail.com", "Sneha Rai", "A Frontend Developer");
            portal.uploadContent("vikas.sharma@gmail.com", "Vikas Sharma", "A Python Developer");

            //initiating bussiness process by one broadcast behaviour
            // static function or member function
            portal.triggerCampusing();
        }
    }
}