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
        private static JobPortal portal = new JobPortal();
        private List<Resume> resumeList=new List<Resume>();

        //Private constructor
        private JobPortal(){
            
        }
        public static JobPortal GetJob(){
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

            //JobPortal thePortal = new JobPortal();
            //thePortal.get();


            JobPortal.GetJob().uploadContent("pranav.taware@gmail.com", "Pranav Taware", "A dotnet developer");
            JobPortal.GetJob().uploadContent("amit.kumar@gmail.com", "Amit Kumar", "A Java Developer");
            JobPortal.GetJob().uploadContent("sneha.rai@gmail.com", "Sneha Rai", "A Frontend Developer");
            JobPortal.GetJob().uploadContent("vikas.sharma@gmail.com", "Vikas Sharma", "A Python Developer");

            JobPortal.GetJob().triggerCampusing(); 
        }
    }
}