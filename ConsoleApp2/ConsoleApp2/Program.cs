// ⦁	Створити об’єкт класу „числова послідовність” (містить <= 5  членів).
// Визначити за допомогою методу класу,
// найменше середнє квадратичне відхилення між послідовними членами.

using System;
using ConsoleApp2;

double[] sequence = [1.5, 2.3, 3.7, 5.1, 6.8]; // Example sequence

var numericSequence = new NumericSequence(sequence);
var minStandardDeviation = numericSequence.CalculateStandardDeviation();

Console.WriteLine("Minimum standard deviation between consecutive members: " + minStandardDeviation);