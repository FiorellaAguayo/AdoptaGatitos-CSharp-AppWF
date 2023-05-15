using System.Text;

namespace ClassLibrary1
{
    public class FileController
    {
        //escribe UN USUARIO
        public static void WriteUser(User user, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
               sw.WriteLine($"{user.Id},{user.Email},{user.UserName},{user.Password},{user.Role}");
            }
        }

        //escribe USUARIOS
        public static void WriteUsers(List<User> users, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (User user in users)
                {
                    sw.WriteLine($"{user.Id},{user.Email},{user.UserName},{user.Password}");
                }
            }
        }

        //parser
        public static List<User> ReadUser(string path)
        {
            List<User> users = new List<User>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] fields = line.Split(',');
                        User user = new User(int.Parse(fields[0]),fields[1], fields[2], fields[3], fields[4]);
                        users.Add(user);
                    }
                }
            }
            return users;
        }

        public static string ShowUserList(string path) 
        { 
            string userList = File.ReadAllText(path);
            return userList;
        }
    }
}