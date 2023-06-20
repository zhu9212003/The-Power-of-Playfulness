%%% 'The Power of Playfulness' %%%

% Code to illustrate different aspects of playfulness 

% First we define a range of values 
x = -2*pi:pi/50:2*pi;

% Now we plot a graph of the sine wave
y = sin(x);
plot(x,y);
title('Sine Wave');

% Here we can illustrate the idea of creating patterns
grid on;
hold on;

% Setting up the code to produce a flower pattern 
t = 0 : 0.1 : 2*pi;
r = 1.5 * sin(5*t) + 2.5;
[x,y] = pol2cart(t,r);
plot(x,y,'r');

% We can also play around with the colour to give the 
% flower a more lifelike appearance 
colors = hsv(45);
for i = 1:45
    plot(x(i), y(i), 'o', 'Color', colors(i,:));
end
hold off;

% This is an example of how we can use playfulness to
% create an exciting visual experience. 
xlim([-4 4]);
ylim([-4 4]);
axis equal;

% We can also use playfulness to explore mathematical
% concepts. Here we will create a surface plot to
% illustrate a hyperboloid. 
syms x y z;
f = x^2 + y^2 - z^2 - 1;
[x,y] = meshgrid(-4:0.5:4);
z = sqrt(x.^2 + y.^2 + 1);

figure;
surf(x,y,z);
title('Hyperboloid');

% We can also use playfulness to explore other 
% types of data. Here we will create a scatter plot
% from a set of random values. 
figure;
randX = 10 * randn(100,1);
randY = 10 * randn(100,1);
scatter(randX,randY);
title('Random Data');

% Finally, we can use playfulness to explore the 
% possibilities of programming and automation. 
% Here we program a loop to draw a spiralling line. 
% First, we set up the plot and define the parameters 
figure;
ang = linspace(0,2*pi,1000);
x = linspace(0,10,1000);
y = linspace(0,10,1000);

% then we loop to draw the line
for i = 1:length(x)
    plot(x(1:i),y(1:i)*sin(ang(i)));   
    hold on;
    drawnow;
end
title('Spiralling Line');