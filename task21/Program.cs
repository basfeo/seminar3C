int[] GetPoint(string text){
    Console.WriteLine(text);
    int[] point = Array.ConvertAll(Console.ReadLine()!.Split(", "), int.Parse);
    return point;
}


void Distance(int[] point1, int[] point2){
    Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(point1[0]-point2[0],2) + Math.Pow(point1[1]-point2[1],2) + Math.Pow(point1[2]-point2[2],2)),2));
}


int[] point1 = GetPoint("Input first!");
int[] point2 = GetPoint("Input second!");

Distance(point1, point2);