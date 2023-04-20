public class Course{
    // will have a list of enrolled students
    private List<Student> enrolledStudents{get;set;}
    private String CourseName{get;set;}
    private String CourseId{get;set;}

    public Course(String courseName, String courseId){
        enrolledStudents = new List<Student>();
        CourseName = courseName;
        CourseId = courseId;
    }

    public void addStudent(Student student){
        enrolledStudents.Add(student);
    }

    public void removeStudent(Student student){
        enrolledStudents.Remove(student);
    }

    //get course name
    public String getCourseName(){
        return CourseName;
    }

    //get course id
    public String getCourseId(){
        return CourseId;
    }
}