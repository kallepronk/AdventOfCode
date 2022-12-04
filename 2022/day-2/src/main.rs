use std::fs::File;
use std::io::{self, BufRead};
use std::path::Path;
use std::str::FromStr;

#[derive(Debug, PartialEq)]
enum EnemyMove{
    A = 1,
    B = 2,
    C = 3,
}

#[derive(Debug, PartialEq)]
enum PlayerMove{
    X = 1,
    Y = 2,
    Z = 3,
}


fn main() {
    let path = Path::new("/Users/kallepronk/Documents/Projects/AdventOfCode/2022/day-2/src/input.txt");
    let mut score: i32 = 0;
    if let Ok(lines) = read_lines(path) {
        for line in lines{
            if let Ok(ip) = line{
                let v: Vec<&str> = ip.split(" ").collect();
                let enemy = EnemyMove::from_str(v[0]).unwrap();
                let player = PlayerMove::from_str(v[1]).unwrap();
                
                score = calculate_score(enemy, player);
                println!("{}", score);
            }
        }
        println!("{}", score);
    }
    else {
        println!("HALP");
    }
}

fn calculate_score(enemy:EnemyMove, player:PlayerMove) -> i32
{
    let enemy_int: i32 = enemy as i32;
    let player_int: i32 = player as i32;
    if &player_int == &enemy_int {
        return &player_int + 3
    }
    else if &player_int - &enemy_int == -1|| &player_int - &enemy_int == 2{
        return &player_int + 6
    }
    else {
        return &player_int + 0
    }
}


impl FromStr for EnemyMove {

    type Err = ();

    fn from_str(input:&str) -> Result<EnemyMove, Self::Err>{
        match input {
            "A" => Ok(EnemyMove::A),
            "B" => Ok(EnemyMove::B),
            "C" => Ok(EnemyMove::C),
            _   => Err(()),
        }
    }
}

impl FromStr for PlayerMove {

    type Err = ();

    fn from_str(input:&str) -> Result<PlayerMove, Self::Err>{
        match input {
            "X" => Ok(PlayerMove::X),
            "Y" => Ok(PlayerMove::Y),
            "Z" => Ok(PlayerMove::Z),
            _   => Err(()),
        }
    }
}


fn read_lines<P>(filename: P) -> io::Result<io::Lines<io::BufReader<File>>>
where P: AsRef<Path>, {
    let file = File::open(filename)?;
    Ok(io::BufReader::new(file).lines())
}
