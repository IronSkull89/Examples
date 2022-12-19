int[] array = {23, 65, 21, 80, 54, 40, 15, 10, 1};

int find = 80;

int index = 0;

while(index < array.Length) {
    if (array[index] == find) {
        Console.WriteLine(index);
        break;
    }
    index++;
}