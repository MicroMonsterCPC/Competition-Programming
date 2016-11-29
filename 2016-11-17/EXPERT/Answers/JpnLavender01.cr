
class Application
  def main
    gc = get_code
    if gc[0] == "decode"
      puts gc[1].deciphering(code)
    elsif gc[0] == "encode"
      puts gc[1].deciphering(code.invert)
    else 
      puts "Optinon at Encode or Decode Only"
    end
  end

  def get_code : Array
    gets.to_s.chomp.split(" ")
  end

  def code : Hash
    return {
      "a" => "l", "b" => "v",
      "c" => "x", "d" => "s",
      "e" => "w", "f" => "d",
      "g" => "f", "h" => "g",
      "i" => "u", "j" => "h",
      "k" => "j", "l" => "k",
      "m" => "n", "n" => "b",
      "o" => "i", "p" => "o",
      "q" => "p", "r" => "e",
      "s" => "a", "t" => "r",
      "u" => "y", "v" => "c",
      "w" => "q", "x" => "z",
      "y" => "t", "z" => "m" }
  end
end

class String
  def deciphering(code : Hash)
    ary = Array(String).new 
    self.split("").each do |v|
      ary << code[v]
    end
    return ary.join("")
  end
end

Application.new.main
