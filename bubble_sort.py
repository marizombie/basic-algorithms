def bubble_sort(array):
    list_len = len(array)
    num_swaps = 0
    
    for i in range(list_len):
        for j in range(list_len-1):
            if array[j] < array[j+1]: continue
            array[j], array[j+1] = array[j+1], array[j]
            num_swaps += 1
                
    return num_swaps, array

    
def print_result(array):
    num, sorted_array = bubble_sort(array)
    print(f'Array is sorted in {num} swaps')
    print(sorted_array)


a = [45, 34, 2, 67, 10, 23, -2, 22, 100,-40, 28, 4, 6, 8, 2, 102]
print_result(a)
