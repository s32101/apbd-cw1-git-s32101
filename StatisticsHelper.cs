class StatisticsHelper {
    // Meeeeeetooooodaaaaaaaaaa
    public static double CalculateAverage(int[] values) {
        return values.Average();
    }

    // tutaj zwracana jest najwieksza wartosc
    public static int CalculateMax(int[] values) {
        return values.Max();
    }

// tu zostanie zwrocona najmniejsza wartość
// wszystko dzięki magii interfejsu IEnumerable<T>,
// ktory jest lepszy od stream api z javy
    public static int CalculateMin(int[] values) {

    }
}
