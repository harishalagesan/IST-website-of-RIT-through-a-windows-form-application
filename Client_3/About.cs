using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_3
{
    //About section
    class About
    {
        public string title { get; set; }
        public string description { get; set; }
        public string quote { get; set; }
        public string quoteAuthor { get; set; }

    }

    //Degrees
    class Degree1
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }



    }

    class Degree2
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }


    }

    class Degree3
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }


    }

    class gDegree1
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }



    }

    class gDegree2
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }



    }

    class gDegree3
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }


    }

    class advDegree
    {
        
            public string degreeName { get; set; }
            public List<string> availableCertificates { get; set; }
        
    }

    //Minors
    class Minor1
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> courses { get; set; }

    }

    class Minor2
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> courses { get; set; }

    }

    class Minor3
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> courses { get; set; }

    }

    class Minor4
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> courses { get; set; }

    }

    class Minor5
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> courses { get; set; }

    }

    class Minor6
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> courses { get; set; }

    }

    class Minor7
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> courses { get; set; }

    }

    class Minor8
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> courses { get; set; }

    }


    public class Content
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class EmployIntro
    {
        public string title { get; set; }
        public List<Content> content { get; set; }
    }

    public class Statistic
    {
        public string value { get; set; }
        public string description { get; set; }
    }

    public class degstat
    {
        public List<Statistic> statistics { get; set; }
    }

    public class Employer
    {
        public string employerNames { get; set; }
    }

    public class emp
    {
        public string title { get; set; }
        public List<Employer> employerNames { get; set; }
    }

    public class researcharea
    {
        public string areaName { get; set; }
        public List<string> citations { get; set; }
    }

    //Tables

    public class CoopInformation
    {
        public string employer { get; set; }
        public string degree { get; set; }
        public string city { get; set; }
        public string term { get; set; }
    }

    public class CoopTable
    {
        public string title { get; set; }
        public List<CoopInformation> coopInformation { get; set; }
    }

    public class ProfessionalEmploymentInformation
    {
        public string employer { get; set; }
        public string degree { get; set; }
        public string city { get; set; }
        public string title { get; set; }
        public string startDate { get; set; }
    }

    public class EmploymentTable
    {
        public string title { get; set; }
        public List<ProfessionalEmploymentInformation> professionalEmploymentInformation { get; set; }
    }


    public class Employment
    {
        public CoopTable coopTable { get; set; }
        public EmploymentTable employmentTable { get; set; }
    }

    //Resources

    public class Place
    {
        public string nameOfPlace { get; set; }
        public string description { get; set; }
    }

    public class StudyAbroad
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<Place> places { get; set; }
    }

    public class Faq
    {
        public string title { get; set; }
        public string contentHref { get; set; }
    }

    public class AcademicAdvisors
    {
        public string title { get; set; }
        public string description { get; set; }
        public Faq faq { get; set; }
    }

    public class AdvisorInformation
    {
        public string name { get; set; }
        public string department { get; set; }
        public string email { get; set; }
    }

    public class ProfessonalAdvisors
    {
        public string title { get; set; }
        public List<AdvisorInformation> advisorInformation { get; set; }
    }

    public class FacultyAdvisors
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class MinorAdvisorInformation
    {
        public string title { get; set; }
        public string advisor { get; set; }
        public string email { get; set; }
    }

    public class IstMinorAdvising
    {
        public string title { get; set; }
        public List<MinorAdvisorInformation> minorAdvisorInformation { get; set; }
    }

    public class StudentServices
    {
        public string title { get; set; }
        public AcademicAdvisors academicAdvisors { get; set; }
        public ProfessonalAdvisors professonalAdvisors { get; set; }
        public FacultyAdvisors facultyAdvisors { get; set; }
        public IstMinorAdvising istMinorAdvising { get; set; }
    }

    public class TutorsAndLabInformation
    {
        public string title { get; set; }
        public string description { get; set; }
        public string tutoringLabHoursLink { get; set; }
    }

    public class SubSectionContent
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class StudentAmbassadors
    {
        public string title { get; set; }
        public string ambassadorsImageSource { get; set; }
        public List<SubSectionContent> subSectionContent { get; set; }
        public string applicationFormLink { get; set; }
        public string note { get; set; }
    }

    public class GraduateForm
    {
        public string formName { get; set; }
        public string href { get; set; }
    }

    public class UndergraduateForm
    {
        public string formName { get; set; }
        public string href { get; set; }
    }

    public class Forms
    {
        public List<GraduateForm> graduateForms { get; set; }
        public List<UndergraduateForm> undergraduateForms { get; set; }
    }

    public class EnrollmentInformationContent
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class CoopEnrollment
    {
        public string title { get; set; }
        public List<EnrollmentInformationContent> enrollmentInformationContent { get; set; }
        public string RITJobZoneGuidelink { get; set; }
    }

    public class COOP
    {
        public string title { get; set; }
        public string subTitle { get; set; }
        public StudyAbroad studyAbroad { get; set; }
        public StudentServices studentServices { get; set; }
        public TutorsAndLabInformation tutorsAndLabInformation { get; set; }
        public StudentAmbassadors studentAmbassadors { get; set; }
        public Forms forms { get; set; }
        public CoopEnrollment coopEnrollment { get; set; }
    }

    //People class
    public class Faculty
    {
        public string username { get; set; }
        public string name { get; set; }
        public string tagline { get; set; }
        public string imagePath { get; set; }
        public string title { get; set; }
        public string interestArea { get; set; }
        public string office { get; set; }
        public string website { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string twitter { get; set; }
        public string facebook { get; set; }
    }

    public class people
    {
        public List<Faculty> faculty { get; set; }
    }

    //staff
    public class Staff
    {
        public string username { get; set; }
        public string name { get; set; }
        public string tagline { get; set; }
        public string imagePath { get; set; }
        public string title { get; set; }
        public string interestArea { get; set; }
        public string office { get; set; }
        public string website { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string twitter { get; set; }
        public string facebook { get; set; }
    }

    public class staf
    {
        public List<Staff> staff { get; set; }
    }

    //News 
    public class Year
    {
        public string date { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

    public class Quarter
    {
        public string date { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

    public class Month
    {
        public string date { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

    public class Older
    {
        public string date { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

    public class News
    {
        public List<Year> year { get; set; }
        public List<Quarter> quarter { get; set; }
        public List<Month> month { get; set; }
        public List<Older> older { get; set; }
    }


    //Faculty by research area
    public class ByFaculty
    {
        public string facultyName { get; set; }
        public string username { get; set; }
        public List<string> citations { get; set; }
    }

    public class facres
    {
        public List<ByFaculty> byFaculty { get; set; }
    }


}
