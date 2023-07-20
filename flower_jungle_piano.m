%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% The Power of Playfulness

%This code explores the power of playfulness in a simple example.

%Initialize the variables
x = 0;
y = 0;

%Create a loop to iterate through the following actions 
while x<10 
    x = x+1;
    if mod(x,2)==0 
        y = y+1; % Increment y if x is even
    end
end

%Output the results
fprintf('x is: %d \n',x);
fprintf('y is: %d \n',y);

%Define a functon to demonstrate the power of playfulness
function hasbro_game(a,b)
   
    %Initialize variables
    game_over = 0;
    player_1 = 0;
    player_2 = 0;
    
    while game_over==0
        %Choose random numbers between a and b
        random_number_1 = randi([a,b]);
        random_number_2 = randi([a,b]);
        %Determine the winner of the round
        if random_number_1 > random_number_2
            player_1 = player_1 + 1;
        elseif random_number_2 > random_number_1
            player_2 = player_2 + 1;
        end
        %Stop the game if either player has three points
        if player_1 == 3 || player_2 == 3
            game_over = 1;
            fprintf('Player 1 has %d points \n',player_1);
            fprintf('Player 2 has %d points \n',player_2);
            %Determine the winner
            if player_1 > player_2
                fprintf('Player 1 wins! \n');
            elseif player_2 > player_1
                fprintf('Player 2 wins! \n');
            end
        end
    end
end

%Run the Hasbro Game
hasbro_game(1,5);