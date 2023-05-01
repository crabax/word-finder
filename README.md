# Word Finder
Word Search library that uses a character matrix and a stream of words to find coincidences.
We are going through each requirement to explain how I addressed them.
First, I transformed the initial matrix `IEnumerable<string>` into a `char[][]` by using `matrix.Select(s => s.ToCharArray()).ToArray()`. That way we can iterate every dimension of the matrix easier. Using `char[,]` would have made it more difficult to transform the initial matrix as we would have needed explicitly iterate the IEnumerable and copy each item into the multi-dimensional char array becasuse there are no built-in methods to do this job.

### Requirements
> Words may appear horizontally, from left to right, or vertically, from top to bottom.

To acomplish that, I created a method called "ProcessRow" that takes the word to be found, and the row where we want to search into.

    private int ProcessRow(string word, char[] row)

We can reuse this method regardless of whether the row is horizontal or *vertical* (explained below). We just need to send the right set of chars.

For evaluating from left to right we just pass the desired row (X<sub>0</sub> - X<sub>n</sub>):

    var row = _matrix[x]; // row 0,1,etc.
    var timesFound = ProcessRow(word, row);

For evaluating from top to bottom we first have to get the columns (Y<sub>0</sub> - Y<sub>n</sub>):

    var row = _matrix.Select(charArray => charArray[x]).ToArray(); //col 0,1,etc.
    var timesFound = ProcessRow(word, row);
--

> The "Find" method should return the top 10 most repeated words.

I created an int property pre-defined with 10 to hanle the "most repeated words". This value can be modified for testing purposes (as you can see in the Unit Tests).  
<br/>
<br/>
> If any word in the word stream is found more than once within the stream, the search results should count it only once.

I use a `Dictionary<string, int>` to store each word and the number of times it appears in the matrix.  
<br/>
<br/>
> High performance, efficient algorithm and utilization of system resources.

The PoC project (console app) helped me to register the time the algorithm takes to complete each task. The results are the following:

 - **Matrix 5x5**: 3 words. Completed in 0,0077878 seconds (7,7878 ms)
 - **Matrix 15x15**: 10 words. Completed in 0,0083149 seconds (8,3149 ms)
 - **Matrix 64x64**: 15 words. Completed in 0,0091297 secods (9,1297 ms)
 - **Matrix 64x64**: 20 ***unique*** words. Completed in 0,0114167 secods (11,4167 ms)

*Console Output:*
![image](https://user-images.githubusercontent.com/15057780/235491965-7582ab9a-0bee-43ff-9856-4680229ca04a.png)


The final portion of code is explained as follows:

 1. Filter the words that weren't found.
 2. Order descending by the number of times the words were found. 
 3. Take the desired *most repeated words*.
 4. Return the result. 

--

    return wordsFound.Select(m => new 
    {
        Word = m.Key,
        Count = m.Value,
    })
    .Where(m => m.Count > 0)
    .OrderByDescending(m => m.Count)
    .ThenBy(m => m.Word)
    .Take(TopMostRepeated)
    .Select(m => m.Word)
    .ToList();
    
# Creator.cs
You can use this class to create and populate matrices to test the code. It fills the "blank" spaces with the letter "f" to make it easier to view the actual words:  
<br/>
![image](https://user-images.githubusercontent.com/15057780/235494484-c4ed7c3e-8dd5-4deb-98f2-254e3a2b134d.png)
