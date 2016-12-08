class Application
	def main
		processing( split_value(input) )
	end

  def processing( s_value : Array )
    value_length = s_value.size
    printf s_value[0]
    (value_length - 1).times do |i|
      printf s_value[i+1].upper
    end
  end

	def split_value(value : String) : Array
    return value.split("_")
	end

	def input : String
		return gets.to_s.chomp
	end
end

class String
  def upper : String
    ary = self.split("")
    change_word = ary[0].capitalize
    ary.delete_at(0)
    return ary.unshift(change_word).join("")
  end
end

Application.new.main
