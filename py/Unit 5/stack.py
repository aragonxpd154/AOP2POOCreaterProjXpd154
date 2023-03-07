# push (append) (ok)
# pop (pop)
# top (stack[N-1])
# empty (True se a pilha for vazia)

# Use push

stack = []

#for i in range(10):
#    stack.append(i)
#    print(stack)
    
    
print('\n')
# Use top

for i in range(10):
    stack.append(i)
    print(stack, "Top = %d" %stack [len(stack)-1])