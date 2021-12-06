int CharArrayToInt(char arr[], int size)
{
    char* start = &arr[0];
    int total = 0;
    int i = 1;

    while (i < size)
    {
        total <<=1;
        if(*start++ == '1')
        {
            total ^= 1;
        }
        i++;
    }

    return total;
}