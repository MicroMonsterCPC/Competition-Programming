class Application
  def main
    puts processing ( get_code )
  end

  def processing(values : Array) : String
    index_id = (values[0].to_s.to_i - 1)
    return generation_alphabet[index_id] == values[1] ? "OK" : "NO"
  end

  def generation_alphabet : Array
    return ("A".."Z").to_a
  end

  def get_code : Array
    input_value = gets.to_s.chomp.split(" ")
    return input_value
  end
end

Application.new.main
