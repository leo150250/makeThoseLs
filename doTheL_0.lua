Message = {}

Message.__index = Message

function Message.new(letter)
   local ply = {}
   setmetatable(ply,Message)
   ply.letter = letter
   return ply
end

function Message:getL()
   while(true)do
      local pleaseGiveMeTheRightLetterLowerCase = math.random(97,122)
      local pleaseGiveMeTheRightLetterUpperCase = math.random(65,90)
      if(string.char(pleaseGiveMeTheRightLetterLowerCase) == 'l' and string.char(pleaseGiveMeTheRightLetterUpperCase) == 'L') then
         return 'l','L'
      end
   end
end

function Message:VerifyIfisEqualL(letter)
   local lowerL,upperL = table.unpack(letter)
   local l,L = self:getL()
   if(  lowerL == 'l' and upperL == 'L') then
      return self:getL()
   end
end

local myMessage = Message.new()


local _,__ = myMessage:VerifyIfisEqualL({myMessage:getL()})

print(__)



