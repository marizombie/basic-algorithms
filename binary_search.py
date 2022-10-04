def binary_search(elements, number):
    left, right = 0, len(elements)-1

    if elements[left] == number: 
        print(f'found the number {number} at index {left}')
        return left
    elif elements[right] == number:
        print(f'found the number {number} at index {right}')
        return right

    while left < right:
        middle_index = left + (right - left) // 2
        if elements[middle_index] == number:
            print(f'found the number {number} at index {middle_index}')            
            return middle_index
        elif number < elements[middle_index]:
            right = middle_index - 1
        elif number > elements[middle_index]:
            left = middle_index + 1
    
    print(f'number {number} not found in the array')
    return -1

els = [2, 4, 5, 6, 9, 24, 25, 48, 59, 100]

binary_search(els, 0)
binary_search(els, -100)
binary_search(els, 20)

binary_search(els, 24)
binary_search(els, 5)
binary_search(els, 9)

binary_search(els, 100)
binary_search(els, 2)
