using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A simple school roster that lists the students
/// in each grade
/// </summary>
public class School
{
    public School ()
	{
        Roster = new Dictionary<uint, ISet<string>>();
	}

    /// <summary>
    /// The school roster. The key is the grade, the value is the list
    /// of students for that grade.
    /// </summary>
    public IDictionary<uint, ISet<string>> Roster { get; private set; }

    /// <summary>
    /// Adds the given student to the given grade
    /// </summary>
    /// <param name="student"></param>
    /// <param name="grade"></param>
    public void Add(string student, uint grade)
    {
        if (!Roster.ContainsKey(grade))
            Roster[grade] = new SortedSet<string>();

        Roster[grade].Add(student);
    }

    /// <summary>
    /// Returns a list of students in the given grade
    /// </summary>
    /// <param name="grade">The grade</param>
    /// <returns>A list of students</returns>
    public ISet<string> Grade(uint grade)
    {
        if(!Roster.ContainsKey(grade))
            return new SortedSet<string>();
        return Roster[grade];
    }
}
