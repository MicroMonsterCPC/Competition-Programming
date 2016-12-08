input = gets.chomp.split("_")
printf input[0]
for i in 1..(input.length - 1) do
  printf input[i].capitalize!
end
