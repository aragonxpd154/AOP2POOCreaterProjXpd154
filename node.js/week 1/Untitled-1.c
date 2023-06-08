// Implements a dictionary's functionality

#include <stdbool.h>
#include <ctype.h>
#include <stdlib.h>
#include <stdio.h>
#include "dictionary.h"
#include <string.h>

// Represents a node in a hash table
typedef struct node
{
char word[LENGTH + 1];
struct node *next;
}
node;

// Number of buckets in hash table
const unsigned int TABLE_SIZE = 100000; // Increased the table size

// Hash table
node *table[TABLE_SIZE];

// Returns true if word is in dictionary else false
bool check(const char *word)
{
// Converts word to lowercase and returns true if found else return false.
int index = hash(word);
node *cursor = table[index];
while (cursor != NULL)
{
if (strcasecmp(cursor->word, word) == 0)
{
return true;
}
cursor = cursor->next;
}
return false;
}

// Hashes word to a number
unsigned int hash(const char *word)
{
// Improved hash function to produce more unique hash values.
unsigned int hashvalue = 0;
for (int i = 0, n = strlen(word); i < n; i++)
{
hashvalue = (hashvalue << 2) ^ tolower(word[i]); // bitwise left shift to double the hash value
}
return hashvalue % TABLE_SIZE; // table size remains same
}

// Loads dictionary into memory, returning true if successful else false
bool load(const char *dictionary)
{
// Loads all data in a hash table and returns true if successful else false.
FILE *file = fopen(dictionary, "r");
if (file == NULL)
{
return false;
}
char word[LENGTH + 1];
while (fscanf(file, "%s", word) != EOF)
{
node *newNode = malloc(sizeof(node));
if (newNode == NULL)
{
return false;
}
strcpy(newNode->word, word);
newNode->next = NULL;
int index = hash(word);
if (table[index] == NULL)
{
table[index] = newNode;
}
else
{
newNode->next = table[index];
table[index] = newNode;
}
}
fclose(file);
return true;
}

// Returns number of words in dictionary if loaded else 0 if not yet loaded
unsigned int size(void)
{
// Counts the number of nodes in the hash table and returns the count.
unsigned int count = 0;
for (int i = 0; i < TABLE_SIZE; i++)
{
node *cursor = table[i];
while (cursor != NULL)
{
count++;
cursor = cursor->next;
}
}
return count;
}

// Unloads dictionary from memory, returning true if successful else false
bool unload(void)
{
// Frees all memory allocated by load function and returns true if successful else false.
for (int i = 0; i < TABLE_SIZE; i++)
{
node *cursor = table[i];
while (cursor != NULL)
{
node *tmp = cursor;
cursor = cursor->next;
free(tmp);
}
}
return true;
}