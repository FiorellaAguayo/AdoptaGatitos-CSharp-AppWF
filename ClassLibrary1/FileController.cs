namespace ClassLibrary1
{
    public class FileController
    {
        public static void WriteUser(List<User> users, string path)
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
                        User user = new User(fields[0], fields[1], fields[2]);
                        users.Add(user);
                    }
                }
            }
            return users;
        }
    }
}