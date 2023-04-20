public interface IDepartmentService {
    void addCourse(Course course);
    void removeCourse(Course course);
    void addInstructor(Instructor instructor);
    void removeInstructor(Instructor instructor);
    void addStudent(Student student);
    void removeStudent(Student student);
    void setHeadOfDepartment(Instructor instructor);
    Instructor getHeadOfDepartment();
    void setBudget(decimal budget);
    decimal getBudget();
    List<Course> getCourses();
    List<Instructor> getInstructors();
    List<Student> getStudents();
}