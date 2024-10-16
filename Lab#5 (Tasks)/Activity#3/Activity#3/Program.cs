using System;

namespace Activity3
{
    public class WorkItem
    {
        private static int currentID = 0;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan JobLength { get; set; }

        public WorkItem()
        {
            ID = GetNextID();
            Title = "Default Title";
            Description = "Default Description";
            JobLength = new TimeSpan();
        }

        public WorkItem(string title, string description, TimeSpan jobLength)
        {
            ID = GetNextID();
            Title = title;
            Description = description;
            JobLength = jobLength;
        }

        protected static int GetNextID()
        {
            return ++currentID;
        }

        public virtual void Update(string title, TimeSpan jobLength)
        {
            Title = title;
            JobLength = jobLength;
        }

        public override string ToString()
        {
            return $"WorkItem ID: {ID}, Title: {Title}, Description: {Description}, Job Length: {JobLength}";
        }
    }

    public class ChangeRequest : WorkItem
    {
        protected int OriginalItemID { get; set; }

        public ChangeRequest() : base()
        {
        }

        public ChangeRequest(string title, string description, TimeSpan jobLength, int originalItemID)
            : base(title, description, jobLength)
        {
            OriginalItemID = originalItemID;
        }

        public ChangeRequest(int originalItemID) : base()
        {
            OriginalItemID = originalItemID;
        }

        public override void Update(string title, TimeSpan jobLength)
        {
            base.Update(title, jobLength);
        }

        public override string ToString()
        {
            return base.ToString() + $", Original Item ID: {OriginalItemID}";
        }
    }

    public class Program 
    {
        static void Main(string[] args)
        {
            WorkItem item = new WorkItem("Fix Bugs", "Fix all bugs in my code branch", new TimeSpan(3, 4, 0, 0));
            ChangeRequest change = new ChangeRequest("Change Base Class Design", "Add members to the class", new TimeSpan(4, 0, 0), 1);

            Console.WriteLine(item.ToString());
            change.Update("Change the Design of the Base Class", new TimeSpan(4, 0, 0));
            Console.WriteLine(change.ToString());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
