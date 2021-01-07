namespace ClassManagementSystem.Interface
{
    public interface ITeacherBusiness
    {
        public void AddTeacher(int id, string name, string major, string passwd);
        public bool TeacherLogin(int id, string passwd);
        public void SelectTeacher(int id);
    }
}