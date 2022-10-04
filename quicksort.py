def quicksort(array):
    less = []
    equal = []
    greater = []

    if len(array) > 1:
        pivot = array[0]

        for element in array:
            if element < pivot:
                less.append(element)
            elif element == pivot:
                equal.append(element)
            elif element > pivot:
                greater.append(element)
        return quicksort(less) + equal + quicksort(greater)
    else:
        return array


res = quicksort([45, 34, 2, 67, 10, 23, 13, 21, 89, 0, -2, 22, 100,-40, 28, 4, 6, 8, 2, 102])
print(res)