class Application
  def initialize
    @line           = "#{gets.chomp} #{gets.chomp} #{gets.chomp}".split(" ")
    @processing_num = gets.to_i
    @move_data      = []
  end
  attr_accessor :line, :processing_num, :move_data

  def main
    get_move_data
    processing
    l = @line
    puts "#{l[0]} #{l[1]} #{l[2]} #{l[3]}"
    puts "#{l[4]} #{l[5]} #{l[6]} #{l[7]}"
    puts "#{l[8]} #{l[9]} #{l[10]} #{l[11]}"
  end

  def get_move_data
    @processing_num.times do
      @move_data << gets.chomp.split(' ')
    end
  end

  def processing
    @move_data.each do |data|
      to_move(data[1], data[0])
    end
  end

  def to_move(app_data, value)
    move_list = { #コレでドコに居るのかわかる
     "1A" => {"top" =>  8, "right" =>  1, "bottom" =>  4, "left" =>  3, "index" => 0 },
     "1B" => {"top" =>  9, "right" =>  2, "bottom" =>  5, "left" =>  0, "index" => 1 },
     "1C" => {"top" => 10, "right" =>  3, "bottom" =>  6, "left" =>  3, "index" => 2 },
     "1D" => {"top" => 11, "right" =>  0, "bottom" =>  7, "left" =>  2, "index" => 3 },
     "2A" => {"top" =>  0, "right" =>  5, "bottom" =>  8, "left" =>  7, "index" => 4 },
     "2B" => {"top" =>  1, "right" =>  6, "bottom" =>  9, "left" =>  4, "index" => 5 },
     "2C" => {"top" =>  2, "right" =>  7, "bottom" => 10, "left" =>  5, "index" => 6 },
     "2D" => {"top" =>  3, "right" =>  4, "bottom" => 11, "left" =>  6, "index" => 7 },
     "3A" => {"top" =>  4, "right" =>  9, "bottom" =>  0, "left" => 11, "index" => 8 },
     "3B" => {"top" =>  5, "right" => 10, "bottom" =>  1, "left" =>  8, "index" => 9 },
     "3C" => {"top" =>  6, "right" => 11, "bottom" =>  2, "left" =>  9, "index" => 10},
     "3D" => {"top" =>  7, "right" =>  8, "bottom" =>  3, "left" => 10, "index" => 11}
    }
    save = @line[move_list[app_data]["index"]]
    @line[move_list[app_data]["index"]] = @line[move_list[app_data][value]]
    @line[move_list[app_data][value]] = save
  end
end

Application.new.main
