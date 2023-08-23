// TODO: Starting in C# 7, you can use _ as a number separator
// int value
int d = 12_34_567; 

// float value
float f = 1_234.5f; 

// hex decimal value
var x = 0xAB_CD_EF; 

// binary value
var b = 0b1101_1110_1001_0010; 

Console.WriteLine($"{d}");
Console.WriteLine($"{f}");
Console.WriteLine($"{b:X}");
Console.WriteLine($"{x:X}");
