use std::fs::File;
use std::io::{self, BufRead};
use std::path::Path;

fn main() {
    let path = Path::new("/Users/kallepronk/Documents/Projects/AdventOfCode/2022/day-1/src/input.txt");
    
    if let Ok(lines) = read_lines(path) {
        // Consumes the iterator, returns an (Optional) String
        let mut my_int:i32 = 0;
        let mut vec:Vec<i32> = Vec::new();
        for line in lines {
            if let Ok(ip) = line {
                match ip.parse::<i32>() {
                    Ok(n) => {
                        my_int += n;
                    },
                    Err(_e) => { vec.push(my_int); my_int = 0;},
                }
            }
        }

        vec.sort();
        let vec2 = vec.split_off(vec.len() - 3);
        let sum:i32 = vec2.iter().sum();
        println!("Biggest calorie count: {}", sum);
    }
    
}


fn read_lines<P>(filename: P) -> io::Result<io::Lines<io::BufReader<File>>>
where P: AsRef<Path>, {
    let file = File::open(filename)?;
    Ok(io::BufReader::new(file).lines())
}