# push (append) (ok)
# pop (pop) (ok)
# top (stack[N-1]) (ok)
# empty (True se a pilha for vazia)

# Use push

stack = []

#for i in range(10):
#    stack.append(i)
#    print(stack)
    
    
#print('\n')
# Use top

for i in range(10):
    stack.append(i)
    print(stack, "Top = %d" %stack [len(stack)-1])
    
lastTop = stack.pop()
print("last Top = %d" % lastTop, stack)

while (len(stack) != 0):
    print(stack, "Top = %d" %stack [len(stack)-1])
    stack.pop()