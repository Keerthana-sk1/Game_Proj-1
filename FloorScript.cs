#include <stdio.h>
#include <string.h>
int main()
{
    FILE *fp1, *fp2, *fp3, *fp4;
    int op, r, start_addr, LOCCTR;
    char LABEL[10];
    char OPCODE[10];
    char OPERAND[10];
    fp1=fopen("Input.txt",'r');
    fp2=fopen("Optab.txt",'r');
    fp3=fopen("Intermediate.txt",'w');
    fp4=fopen("Symtab.txt",'r+'');
    fscanf(fp1,"%s\t%s\t%s\t",LABEL,OPCODE,OPERAND);
    op=(int)(strtol(OPERAND, NULL, 16);
    void search_symtab(char LABEL[10])
    {
        char label[10];
        int address;
        fseek(fp4, 0, SEEK_SET); 
        while(fscanf(fp4,"%s\t%d",label[10], address))!=EOF)
        {
            if(strcmp(label,LABEL)==0)
            return 1;
            else
            return 0;
        }
    }
    if(strcmp(LABEL,'START')==0)
    {
            start_addr=op;
            LOCCTR=start_addr;
            fprintf(fp3,"%s\t%s\t%s\t%d",LABEL,OPCODE,OPERAND,LOCCTR);
            fscanf(fp1,"%s\t%s\t%s\t",LABEL,OPCODE,OPERAND);
    }
    else
    LOCCTR=0;
    
    while (strcmp(LABEL,'END')!=0)
    {
        if(strcmp(LABEL,'**')!=0)
        {
            r=search_symtab(LABEL);
            if(r==0)
            {
               fprintf(fp4,"%s\t\d",LABEL,LOCCTR); 
            }
        }
    }
}
 