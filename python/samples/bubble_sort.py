def bubblesort(lst):
    "Sorts lst in place and returns it."    
    for passesLeft in range(len(lst)-1, 0, -1):
        for index in range(passesLeft):
            if lst[index] > lst[index + 1]:
                lst[index], lst[index + 1] = lst[index + 1], lst[index]
    return lst
