# Rat-Catching-Game
Step 1: design a form that displays the image of a rat and a button to run the game as shown below. You
may find the rat image in Blackboard.
Step 2: When the run button is pressed, the game starts. Run a timer that raises an event every 1.5
seconds.
Also add the following line of code to your namespace.
using System.Diagnostics;
Add a global Stopwatch variable as follows.
Stopwatch watch = new Stopwatch();
Step 3: When the timer interval event occurs, a random number should be generated and the location of
the rat image should change according to the random number. This way the location of the rat changes
randomly every 1.5 seconds.
Step 4: The patient is asked to try to capture the rat by clicking on it. Each time the rat is clicked, display
a messagebox to encourage the patient (like a congratulation message).
Step 5: Each time the picture is successfully clicked, decrease the timer event by 0.25 seconds. This way
the speed of updating the picture will be increased and the game becomes more difficult.
Step 6: Each time the rat is successfully captured, record the location of the picturebox, the time duration
between the previous capture and current capture, and the speed in an array as follows. For the speed you
may record the current timer interval.
For the time duration between each two consecutive captures use ElapsedMilliseconds property of the
stopwatch.
Do not forget to restart the stopwatch each time the rat is captured to successfully record the elapsed time
between each two consecutive captures.

Step 7: after 10 successful captures, calculate the average location by averaging the X and Y columns in
the array.
Also calculate the average of the third column as an index of reaction nonlinearity, which is a scientific
measure of mental health.
Step 8: show the results of step 7 in a Messagebox
