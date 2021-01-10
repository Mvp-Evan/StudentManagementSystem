namespace ClassManagementSystem.Interface
{
    public interface ITeacherBusiness
    {
        /**
         * @param id
         * judge teacher if exists
         */
        public bool TeacherIsExists(int id);
        
        /**
         * @param id, name, major, passwd
         * This function interface can create a teacher entity and save into database by these param
         */
        public void AddTeacher(int id, string name, string major, string passwd);
        
        /**
         * @param id, passwd
         * check teacher Login by check id if exists and password if correct
         */
        public bool TeacherLogin(int id, string passwd);
        
        /**
         * @param id
         * Select teacher information and return it by string
         */
        public string SelectTeacher(int id);
        
        /**
         * @param id
         * delete teacher information by id and check id if exists
         */
        public bool DeleteTeacherById(int id);
    }
}