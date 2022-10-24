# Go from C#

Example building a Go DLL and calling it from C#

Tested when running Go build on Windows platform. Not tested with cross-compiling (i.e. running Go build on linux or Mac).

## Gist

https://gist.github.com/andrewloable/afa1c683701cec18c4530f6a91692e0b

## Build Go shared.dll

First, install Golang for Windows from the Go website. 
Second, install TDM GCC complier from,

https://jmeubank.github.io/tdm-gcc/download/

Then open Command Prompt and cd into this directory. 
By now both `gcc` and `go` commands should be in your PATH, added automatically by above install process.

Then run:

```
> cd go-dll
> go build -o shared.dll -buildmode=c-shared
```


## C# Demo app

Build demo C# app that uses the DLL

```
> cd c-sharp-example
> csc @build.rsp
```

## Errors

If the DLL is not found, you will get an error like this:

```
Unhandled Exception: System.DllNotFoundException: Unable to load DLL 'shared.dll': The specified module could not be found. (Exception from HRESULT: 0x8007007E)
   at GoSharedDLL.Program.ReturnReversedString(Byte[] input)
   at GoSharedDLL.Program.Main(String[] args)
```

## See also:

How to compile C# on command line:

https://tomasvera.com/programming/compiling-a-c-project-using-command-line-tools-tutorial
