puts (Hash[[*'A'..'Z'].map.with_index{|val,i| [(i + 1).to_s,val]}][(ary = (gets.chomp.split(" ")))[0]] == ary[1] ? "OK" : "NO")
