// Create our main sketch
// Code adapted from the P5.js example:
// https://p5js.org/examples/simulate-sunrise.html

let sun;
let clouds = [];
let stars = [];
let gravity;
let sky;

function setup() {
  createCanvas(800, 400);
  sky = color(0, 150, 255);
  sun = new Sun();
  for (let i = 0; i < 40; i++) {
    stars[i] = new Star();
  }
  for (let i = 0; i < 28; i++) {
    clouds[i] = new Cloud();
  }
  gravity = createVector(0, 0.2);

}

function draw() {
  background(sky);
  
  noStroke();
  fill(255);
  let t = frameCount / 60; // update time

  // Set background color
  let g = map(t, 0, 60, 0, 100);
  sky = color(g, 100, 255);

  // Makes the sun move
  let angle = map(t, 0, 50, 0, TWO_PI);
  let x = width * 0.5 + height * 0.45 * cos(angle);
  let y = height * 0.5 + height * 0.45 * sin(angle);
  sun.update(x, y);

  // Set stars
  for (let i = 0; i < stars.length; i++) {
    stars[i].show();
  }

  // move clouds
  for (let i = 0; i < clouds.length; i++) {
    clouds[i].update();
    clouds[i].show();
  }

  // makes the sun show
  sun.show();

}

// Sun class
function Sun() {
  this.x = 0;
  this.y = 0;
  this.diameter = 120;

  this.update = function(x, y) {
    this.x = x;
    this.y = y;
  }

  this.show = function() {
    fill(0);
    noStroke();
    ellipse(this.x, this.y, this.diameter, this.diameter);
  }
}

// Cloud class
function Cloud() {
  this.x = random(width);
  this.y = random(height / 2);
  this.diameter = random(20, 40);

  this.update = function() {
    this.x += random(-1, 1);
    this.y += random(0.1, 0.5);
    if (this.x > width) {
      this.x = 0;
    }
    if (this.y > height / 2) {
      this.y = 0;
    }
  }

  this.show = function() {
    fill(255);
    noStroke();
    ellipse(this.x, this.y, this.diameter, this.diameter);
  }
}

// Star class
function Star() {
  this.x = random(width);
  this.y = random(height);
  this.diameter = random(4, 6);

  this.show = function() {
    fill(255);
    noStroke();
    ellipse(this.x, this.y, this.diameter, this.diameter);
  }
}