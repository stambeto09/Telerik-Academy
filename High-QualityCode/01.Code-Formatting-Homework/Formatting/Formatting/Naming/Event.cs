using System;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

//The StyleCop shows some errors dedicated to documentation headers of classes and methods. I think it's not
//necessary to document them, because they have self-documenting names.
//I fixed three of them, adding some XMLs, but I think it's not proper, specially when each module has a descibing name;
public class Event : IComparable
{
    private readonly DateTime date;
    private readonly string title;
    private readonly string location;

    public Event(DateTime date, string title, string location)
    {
        this.date = date;
        this.title = title;
        this.location = location;
    }

    /// <summary>
    /// Compare the dates and return the result form comparing.
    /// </summary>
    /// <param name="obj">object from type object</param>
    /// <returns>compared date</returns>
    public int CompareTo(object obj)
    {
        Event other = obj as Event;
        int compareByDate = this.date.CompareTo(other.date);
        int compareByTitle = this.title.CompareTo(other.title);
        int compareByLocation = this.location.CompareTo(other.location);

        if (compareByDate == 0)
        {
            if (compareByTitle == 0)
            {
                return compareByLocation;
            }
            else
            {
                return compareByTitle;
            }
        }
        else
        {
            return compareByDate;
        }
    }

    /// <summary>
    /// Method that returns the date and title of the current object.
    /// </summary>
    /// <returns>returns a StringBuilder content with date and title.</returns>
    public override string ToString()
    {
        StringBuilder toString = new StringBuilder();
        toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
        toString.Append(" | " + this.title);

        if (this.location != null && this.location != string.Empty)
        {
            toString.Append(" | " + this.location);
        }

        return toString.ToString();
    }
}

/// <summary>
/// The main class
/// </summary>
public class Program
{
    private static readonly StringBuilder output = new StringBuilder();
    private static readonly EventHolder events = new EventHolder();

    private static bool ExecuteNextCommand()
    {
        string command = Console.ReadLine();
        if (command[0] == 'A')
        {
            AddEvent(command);
            return true;
        }

        if (command[0] == 'D')
        {
            DeleteEvents(command);
            return true;
        }

        if (command[0] == 'L')
        {
            ListEvents(command);
            return true;
        }

        if (command[0] == 'E')
        {
            return false;
        }

        return false;
    }

    private static void ListEvents(string command)
    {
        int pipeIndex = command.IndexOf('|');
        DateTime date = GetDate(command, "ListEvents");
        string countString = command.Substring(pipeIndex + 1);
        int count = int.Parse(countString);
        events.ListEvents(date, count);
    }

    private static void DeleteEvents(string command)
    {
        string title = command.Substring("DeleteEvents".Length + 1);
        events.DeleteEvents(title);
    }

    private static void AddEvent(string command)
    {
        DateTime date;
        string title = string.Empty;
        string location = string.Empty;
        GetParameters(command, "AddEvent", out date, out title, out location);
        events.AddEvent(date, title, location);
    }

    private static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
    {
        dateAndTime = GetDate(commandForExecution, commandType);
        int firstPipeIndex = commandForExecution.IndexOf('|');
        int lastPipeIndex = commandForExecution.LastIndexOf('|');

        if (firstPipeIndex == lastPipeIndex)
        {
            eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
            eventLocation = string.Empty;
        }
        else
        {
            eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
            eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
        }
    }

    private static DateTime GetDate(string command, string commandType)
    {
        DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));
        return date;
    }

    private static void Main(string[] args)
    {
        while (ExecuteNextCommand())
        {
            Console.WriteLine(output);
        }
    }

    public static class Messages
    {
        public static void EventAdded()
        {
            output.Append("Event added\n");
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                output.AppendFormat("{0} events deleted\n", x);
            }
        }

        public static void NoEventsFound()
        {
            output.Append("No events found\n");
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                output.Append(eventToPrint + "\n");
            }
        }
    }

    /// <summary>
    /// Hold the events and manipulate them using Add and Delete event methods.
    /// </summary>
    public class EventHolder
    {
        private readonly MultiDictionary<string, Event> orderedByTitle = 
            new MultiDictionary<string, Event>(true);

        private readonly OrderedBag<Event> orderedByDate = new OrderedBag<Event>();

        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            this.orderedByTitle.Add(title.ToLower(), newEvent);
            this.orderedByDate.Add(newEvent);
            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removedEvents = 0;
            foreach (var eventToRemove in this.orderedByTitle[title])
            {
                removedEvents++;
                this.orderedByDate.Remove(eventToRemove);
            }

            this.orderedByTitle.Remove(title);
            Messages.EventDeleted(removedEvents);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = this.orderedByDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            int showed = 0;
            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);
                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}