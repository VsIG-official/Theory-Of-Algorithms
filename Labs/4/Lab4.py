arr_input = []
arr_medians = []

def heapify(arr, n, i): 
	largest = i 
	l = 2 * i + 1	 
	r = 2 * i + 2	

	if l < n and arr[i] < arr[l]: 
		largest = l 
 
	if r < n and arr[largest] < arr[r]: 
		largest = r 

	if largest != i: 
		arr[i],arr[largest] = arr[largest],arr[i]

		heapify(arr, n, largest) 

def heapSort(arr): 
	n = len(arr) 

	for i in range(n, -1, -1): 
		heapify(arr, n, i) 

	for i in range(n-1, 0, -1): 
		arr[i], arr[0] = arr[0], arr[i] 
		heapify(arr, i, 0)
	return arr

def mediana(arr):
    # sorting array
    arr = heapSort(arr)

    # Calculating the mediana
    if len(arr) % 2 != 0:
        return arr[int((len(arr)-1) / 2)]
    else:
        return [arr[int((len(arr)-1) / 2)], arr[int((len(arr)-1) / 2) + 1]]

# Input
n = int(input('Input number of elements: '))
for i in range(n):
    el = int(input())
    arr_input.append(el)
    arr_medians.append(mediana(arr_input))

# Output
for element in arr_medians:
    print('Mediana is:', element)