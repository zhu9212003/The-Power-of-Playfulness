<?php 

//Line 1
$playfulMotivation = "The Power of Playfulness allows you to be more creative, motivated, and have a better outlook on life.";

//Line 2
$playfulActions = array(
    'Create a Playlist', 
    'Go to the Park',
    'Play Hide and Seek',
    'Have a Dance Party',
    'Have a Laughing Contest',
    'Make a Paper Airplane',
    'Do a Puzzle',
    'Play I Spy With My Little Eye'
);

//Line 3
echo "\"".$playfulMotivation."\"" . "\n\n"; 
echo "To become more playful, here are some ideas: \n\n";

//Line 4-7
foreach($playfulActions as $action) {
    echo "- ".$action."\n";
}

//Line 8
echo "\n";

//Line 9-17
function playfulness($playfulActions) {
    foreach($playfulActions as $action) {
        echo "+ ".$action."\n";
    }
    $playfulMessage = "Try one of these today and have some fun!";
    echo $playfulMessage;
}

//Line 18
echo "\n\n";

//Line 19-25
playfulness($playfulActions);

//Line 26
echo "\n\n";

//Line 27-33
$playfulReminders = array(
    'Laugh every day', 
    'Surround yourself with things that make you smile', 
    'Do something unexpected', 
    'Challenge yourself by trying something new',
    'Daydream often',
    'Engage with your childlike curiosity',
    'Make time for fun activities and adventures'
);

//Line 34-41
echo "Here are some reminders to keep your playfulness alive: \n\n";

foreach($playfulReminders as $reminder) {
    echo "- ".$reminder."\n";
}

//Line 42
echo "\n";

//Line 43-50
function reminders($playfulReminders) {
    foreach($playfulReminders as $reminder) {
        echo "+ ".$reminder."\n";
    }
    $reminderMessage = "Enjoy your day and have some fun!";
    echo $reminderMessage;
}

//Line 51
echo "\n\n";

//Line 52-58
reminders($playfulReminders);

?>