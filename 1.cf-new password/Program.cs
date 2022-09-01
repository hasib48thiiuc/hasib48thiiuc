

string alfabet = "abcdefghijklmnopqrstuvwxyz";
string password = "";
int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int size = inputs[0];
while (inputs[0]-- > 0)
    password += alfabet.Substring(0, inputs[1]);
Console.WriteLine(password.Substring(0, size));


//problem link-https://codeforces.com/contest/770/problem/A
