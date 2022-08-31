class LongestName
{
  public string GetLongest(string[] names)
  {
    string longest = "";
    foreach (string name in names)
    {
      if (longest.Length < name)
      {
        longest = name;
      }
    }
    return longest;
  }
}


// Can you spot the problem with this code?
  // Can't run comparison between integer and string
// Whether or not you found the issue, now run this code in irb. Call the longest_name function by entering puts longest_name(people).
// Did the bug happen when creating the function, or only when calling the function?
  // only when calling the function
// In C#, would the behaviour with such a bug be the same, or different? Why?
  // In C#, the behaviour would be different since it is a compiling language and wouldn't let you compile whereas with Ruby which has an interpreter, the code will run with an error.