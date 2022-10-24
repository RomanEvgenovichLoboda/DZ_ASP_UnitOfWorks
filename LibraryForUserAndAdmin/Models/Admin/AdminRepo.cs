using PZ_ASP_UnitOfWorks.Models.User;

namespace PZ_ASP_UnitOfWorks.Models.Admin
{
    public class AdminRepo : UserRepo
    {
        public AdminRepo(HostContext context) : base(context) { }
        public string PostOneNote(string text)
        {
            Not note = new Not();
            note.Text = text;
            note.Date = DateTime.Now;
            context.Nots.Add(note);
            context.SaveChanges();
            return note.ToString();
        }
        public string DeleteById(int id)
        {
            Not? note = context.Nots.Find(id);
            if (note != null)
            {
                context.Nots.Remove(note);
                context.SaveChanges();
                return $"Delleted - {note}";
            }
            else return "Not Delleted";
        }
    }
}
