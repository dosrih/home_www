// Int32.Parse takes a string, and returns an int, not a string:
int n1 = Int32.Parse("5");
int n2 = Int32.Parse("8");
// Math.Min and Math.Max functions pick the min and max
int min = Math.Min(n1, n2);
int max = Math.Max(n1, n2);
// Show both numbers in a message box in one go using String.Format:
Console.WriteLine(string.Format("Min:{0} Max:{1}", min, max));