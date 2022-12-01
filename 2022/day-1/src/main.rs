use std::fs;

fn main() {
    let data = fs::read_to_string("input.txt").expect("Unable to read file");
    println!("{}", data);
}