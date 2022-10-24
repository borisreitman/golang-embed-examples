package main

import "C"

//export ReturnReversedString
func ReturnReversedString(input *C.char) *C.char {
	str := C.GoString(input)
	runes := []rune(str)
	for i, j := 0, len(runes)-1; i < j; i, j = i+1, j-1 {
		runes[i], runes[j] = runes[j], runes[i]
	}
	retval := string(runes)
	return C.CString(retval)
}

func main() {}

// compile using go build -o shared.dll -buildmode=c-shared
