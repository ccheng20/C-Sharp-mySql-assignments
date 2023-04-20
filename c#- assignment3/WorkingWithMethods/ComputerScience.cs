public class ComputerScience : Department{
    public ComputerScience(){
        Courses = new List<Course>();
        Instructors = new List<Instructor>();
        Students = new List<Student>();
        Budget = 0;
        HeadOfDepartment = null;
    }

    public void addCourse(Course course){
        Courses.Add(course);
    }

    public void removeCourse(Course course){
        Courses.Remove(course);
    }

    public void addInstructor(Instructor instructor){
        Instructors.Add(instructor);
    }

    public void removeInstructor(Instructor instructor){
        Instructors.Remove(instructor);
    }

    public void setHeadOfDepartment(Instructor instructor){
        HeadOfDepartment = instructor;
    }

    public Instructor getHeadOfDepartment(){
        return HeadOfDepartment;
    }

    public void setBudget(decimal budget){
        Budget = budget;
    }

    public decimal getBudget(){
        return Budget;
    }

    public List<Course> getCourses(){
        return Courses;
    }

    public List<Instructor> getInstructors(){
        return Instructors;
    }

    public List<Student> getStudents(){
        return Students;
    }

    public void addStudent(Student student){
        Students.Add(student);
    }

    public void removeStudent(Student student){
        Students.Remove(student);
    }

    public void printCourses() {
        foreach(Course course in Courses) {
            Console.WriteLine(course.getCourseId() + " " + course.getCourseName());
        }
    }

  
}